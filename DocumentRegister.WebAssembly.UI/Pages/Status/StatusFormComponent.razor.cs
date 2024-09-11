using DocumentRegister.WebAssembly.UI.Models.Status;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Status
{
    public partial class StatusFormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public StatusVM StatusModel { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
