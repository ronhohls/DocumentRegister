﻿namespace DocumentRegister.WebAssembly.UI.Services.Base
{
    public class Response<T>
    {
        public string Message { get; set; }
        //to replace with list of errors
        public string ValidationErrors { get; set; }
        public bool Success { get; set; } = true;
        public T Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
