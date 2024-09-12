using DocumentRegister.WebAssembly.UI.Models.MediaType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.MediaType
{
    public partial class MediaTypeFormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public MediaTypeVM MediaTypeModel { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
