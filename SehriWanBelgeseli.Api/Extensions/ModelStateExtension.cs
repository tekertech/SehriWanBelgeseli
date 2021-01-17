using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace SehriWanBelgeseli.Api.Extensions
{
    public static class ModelStateExtension
    {
        public static List<string> GetErrorMessage(this ModelStateDictionary dictionary)  
        {
            return dictionary.SelectMany(m => m.Value.Errors).Select(x => x.ErrorMessage).ToList();
        }
    }
}
