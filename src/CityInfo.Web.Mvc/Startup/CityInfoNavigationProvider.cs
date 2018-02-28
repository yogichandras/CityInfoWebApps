using Abp.Application.Navigation;
using Abp.Localization;
using CityInfo.Authorization;

namespace CityInfo.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class CityInfoNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "folder",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )

                     .AddItem(
                    new MenuItemDefinition(
                        PageNames.DataTempat,
                        L("DataTempat"),
                        url: "Tempat",
                        icon: "business"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Kategori,
                        L("Kategori"),
                        url: "Kategori",
                        icon: "bookmark"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Gallery,
                        L("Gallery"),
                        url: "Galleries",
                        icon: "camera"
                    )

                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info"
                    )
                    );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, CityInfoConsts.LocalizationSourceName);
        }
    }
}
