using DocumentRegister.WebAssembly.UI.Models.DataType;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DataType
{
    public partial class DataTypeFormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public DataTypeVM DataTypeModel { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}