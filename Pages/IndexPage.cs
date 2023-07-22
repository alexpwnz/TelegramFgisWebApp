namespace TelegramFgisWebApp.Pages
{
    using System;
    using System.Threading.Tasks;
    using Blazor.DynamicJavascriptRuntime.Evaluator;
    using Microsoft.AspNetCore.Components;
    using Microsoft.JSInterop;

    public class IndexPage : ComponentBase
    {
        public string name;
        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
           
            using (dynamic context = new EvalContext(JsRuntime))
            {
                name = context.window.Telegram.WebApp.initDataUnsafe.user.first_name;
            }


            await base.OnInitializedAsync();
        }

        

    }
}