﻿namespace WarehouseManagementDesktopApp.Core.Services;

using Syncfusion.CompoundFile.XlsIO.Native;
using System.Windows.Threading;
using MessageBox = WarehouseManagementDesktopApp.Core.ComponentUI.MessageBox;
using Product = Persistence.SqliteDB.Model.Product;

public class StartProgramService : IStartProgramService
{
    private readonly IApiService _apiService;
    private readonly IProductsDatabaseService _productsDatabaseService;
    private readonly IMapper _mapper;
    private readonly IOidcClientService _idcClientService;
    private readonly ProductStore _productStore;
    ObservableCollection<string> _warningStockCards = new ObservableCollection<string>();
    ObservableCollection<string> WarningStockCards { get => _warningStockCards; set { _warningStockCards = value; OnCurrentViewModelChanged(); } }
    private readonly WebBrowserContainer _webBrowserContainer;
    public Action FinishLogin { get; set; }
    public StartProgramService(IApiService apiService, IProductsDatabaseService roductsDatabaseService, IMapper mapper, WebBrowserContainer webBrowserContainer, IOidcClientService oidcClientService, ProductStore productStore)
    {
        _idcClientService = oidcClientService;
        _webBrowserContainer = webBrowserContainer;
        _apiService = apiService;
        _productsDatabaseService = roductsDatabaseService;
        _mapper = mapper;
        _apiService.LoginCompleteAction += StartLoadProduct;
        _productStore = productStore;
    }

    private void StartLoadProduct()
    {
        FinishLogin?.Invoke();
        Thread thread = new Thread(LoadProduct);
        thread.Start();
    }

    public async void LoadLoginView()
    {
        await Task.Delay(10);
        await Task.Run(() => _idcClientService.LoginAsync());
    }
    public async void LoadProgram()
    {
        await Task.Run(() => LoadProduct());
    }
    private async void LoadProduct()
    {
        var data = await _apiService.GetAllProduct();
        if (data.Success)
        {
            var fullproduct = data.Resource.Items;
            List<Persistence.SqliteDB.Model.Product> products = new List<Persistence.SqliteDB.Model.Product>();
            foreach (var item in fullproduct)
            {
                var itemdata = _mapper.Map<Persistence.SqliteDB.Model.Product>(item);
                try
                {

                    products.Add(itemdata);
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                    Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                    {
                    // code...
                    _productStore.ProductId.Add(item.itemId);
                        _productStore.ProductName.Add(item.name);
                    }));
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                }
                catch (Exception ex)
                { }
            }
            _productsDatabaseService.Clear();
            await Task.Run(() => _productsDatabaseService.Insert(products));
        }
        else
        {
            var productList = await _productsDatabaseService.LoadAllProduct();
            foreach (var item in productList)
            {
                _productStore.ProductId.Add(item.IdProduct);
                _productStore.ProductName.Add(item.Name);
            }
        }
    }

    public event Action WarningStockCardsChanged;

    private void OnCurrentViewModelChanged()
    {
        WarningStockCardsChanged?.Invoke();
    }
}
