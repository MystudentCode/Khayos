using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace YumBlazor.Services.Extensions
{
    public static class IJSRuntimeExceptions
    {
        public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}
