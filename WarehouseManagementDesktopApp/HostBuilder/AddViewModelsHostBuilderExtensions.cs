﻿namespace WarehouseManagementDesktopApp.HostBuilder
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices(services =>

            {
                services.AddSingleton<ChatMessageListDesignModel>();
                services.AddSingleton<LoginViewModel>((IServiceProvider serviceprovider) =>
                {
                    var LoginStore = serviceprovider.GetRequiredService<LoginNavigationStore>();
                    return new LoginViewModel(LoginStore, CreateNotifyNavigationService(serviceprovider, LoginStore));
                });
                services.AddSingleton<NotifyViewModel>((IServiceProvider serviceprovider) =>
                {
                    var LoginStore = serviceprovider.GetRequiredService<LoginNavigationStore>();
                    return new NotifyViewModel(LoginStore, CreateLoginNavigationService(serviceprovider, LoginStore),serviceprovider.GetRequiredService<ChatMessageListDesignModel>());
                });
                services.AddSingleton<LoginLayOutViewModel>((IServiceProvider serviceprovider) =>
                {
                    var LoginStore = serviceprovider.GetRequiredService<LoginNavigationStore>();
                    LoginStore.CurrentViewModel = serviceprovider.GetRequiredService<LoginViewModel>();
                    return new LoginLayOutViewModel(LoginStore);

                });
                services.AddSingleton<GoodReceiptOrderViewModel>((IServiceProvider serviceprovider) =>
                {
                    var goodReceiptStore = serviceprovider.GetRequiredService<GoodReceiptNavigationStore>();
                    return new GoodReceiptOrderViewModel(goodReceiptStore, CreateGoodReceiptNavigationService(serviceprovider, goodReceiptStore));
                });
                services.AddSingleton<GoodExportViewModel>();
                services.AddSingleton<GoodLocationViewModel>();
                services.AddSingleton<ProcessingGoodExportViewModel>();
                services.AddSingleton<ReportViewModel>();
                services.AddSingleton<HistoryViewModel>();

                services.AddSingleton<GoodReceiptViewModel>((IServiceProvider serviceprovider) =>
                {
                    var goodReceiptStore = serviceprovider.GetRequiredService<GoodReceiptNavigationStore>();
                    return new GoodReceiptViewModel(goodReceiptStore, CreateGoodReceiptOrderNavigationService(serviceprovider, goodReceiptStore));
                });
                services.AddSingleton<GoodReceiptLayOutViewModel>((IServiceProvider serviceprovider) =>
                {
                    var goodReceiptLayOutrStore = serviceprovider.GetRequiredService<GoodReceiptNavigationStore>();
                    var goodReceiptLayOutViewModel = new GoodReceiptLayOutViewModel(goodReceiptLayOutrStore);
                    goodReceiptLayOutViewModel.CurrentViewModel = serviceprovider.GetRequiredService<GoodReceiptViewModel>();
                    return goodReceiptLayOutViewModel;
                });

                services.AddSingleton<GoodExportLayOutViewModel>((IServiceProvider serviceprovider) =>
                {
                    var goodExportStore = serviceprovider.GetRequiredService<NavigationStore>();
                    return new GoodExportLayOutViewModel(goodExportStore, CreateGoodExportNavigationService(serviceprovider, goodExportStore), CreateProcessGoodExportNavigationService(serviceprovider, goodExportStore));
                });
                services.AddSingleton<MainViewModel>((IServiceProvider serviceprovider) =>
                {
                    var MainStore = serviceprovider.GetRequiredService<NavigationStore>();
                    MainStore.CurrentViewModel = serviceprovider.GetRequiredService<LoginLayOutViewModel>();   
                    return new MainViewModel(MainStore, CreateLayOutNavigationService(serviceprovider, MainStore), CreateLayOutGoodRecieptNavigationService(serviceprovider, MainStore), CreateLayOutGoodExportNavigationService(serviceprovider, MainStore), CreateGoodLocationNavigationService(serviceprovider, MainStore), CreateReportNavigationService(serviceprovider, MainStore), CreateHistoryNavigationService(serviceprovider, MainStore));
                });
            });

            return host;
        }

        private static INavigationService CreateLayOutNavigationService(IServiceProvider serviceprovider, NavigationStore store)
        {
            return new NavigationService<LoginLayOutViewModel>(
                store,
                () => serviceprovider.GetRequiredService<LoginLayOutViewModel>());
        }

        private static INavigationService CreateLoginNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<LoginViewModel>(
                store,
                () => serviceProvider.GetRequiredService<LoginViewModel>());
        }
        private static INavigationService CreateGoodReceiptNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<GoodReceiptViewModel>(
                store,
                () => serviceProvider.GetRequiredService<GoodReceiptViewModel>());
        }
        private static INavigationService CreateGoodReceiptOrderNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<GoodReceiptOrderViewModel>(
                store,
                () => serviceProvider.GetRequiredService<GoodReceiptOrderViewModel>());
        }
        private static INavigationService CreateLayOutGoodExportNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<GoodExportLayOutViewModel>(
                store,
                () => serviceProvider.GetRequiredService<GoodExportLayOutViewModel>());
        }
        private static INavigationService CreateGoodExportNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<GoodExportViewModel>(
                store,
                () => serviceProvider.GetRequiredService<GoodExportViewModel>());
        }
        private static INavigationService CreateProcessGoodExportNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<ProcessingGoodExportViewModel>(
                store,
                () => serviceProvider.GetRequiredService<ProcessingGoodExportViewModel>());
        }
        private static INavigationService CreateGoodLocationNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<GoodLocationViewModel>(
                store,
                () => serviceProvider.GetRequiredService<GoodLocationViewModel>());
        }
        private static INavigationService CreateLayOutGoodRecieptNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<GoodReceiptLayOutViewModel>(
                store,
                () => serviceProvider.GetRequiredService<GoodReceiptLayOutViewModel>());
        }
        private static INavigationService CreateReportNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<ReportViewModel>(
                store,
                () => serviceProvider.GetRequiredService<ReportViewModel>());
        }
        private static INavigationService CreateHistoryNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<HistoryViewModel>(
                store,
                () => serviceProvider.GetRequiredService<HistoryViewModel>());
        }
        private static INavigationService CreateNotifyNavigationService(IServiceProvider serviceProvider, NavigationStore store)
        {
            return new NavigationService<NotifyViewModel>(
                store,
                () => serviceProvider.GetRequiredService<NotifyViewModel>());
        }
    }
}
