using System;

namespace Proyecto1.Models.ViewModel
{
    internal class RequieredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}