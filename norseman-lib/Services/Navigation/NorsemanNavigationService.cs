using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norseman.Lib.Services.Navigation
{
    public class NorsemanNavigationService : INavigationService
    {
        /// <summary>
        /// The initial screen that the app will navigation to. 
        /// </summary>
        /// <returns>Details about the current task</returns>
        public Task InitializeAsync() => NavigateToAsync("//MainPage/");

        /// <summary>
        /// Navigates the user to a different page utilizing the shell
        /// </summary>
        /// <param name="route">The page the user needs to go to</param>
        /// <param name="routeParameters">Any paramters that need to go with the page</param>
        /// <returns>Details about the current task</returns>
        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            return routeParameters != null ? Shell.Current.GoToAsync(shellNavigation, routeParameters) : Shell.Current.GoToAsync(shellNavigation);
        }

        /// <summary>
        /// Navigates the user back a single page
        /// </summary>
        /// <returns>Details about the current task</returns>
        public Task PopAsync() => Shell.Current.GoToAsync("..");
    }
}
