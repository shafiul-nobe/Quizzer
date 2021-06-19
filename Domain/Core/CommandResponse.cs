using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core
{
    public class CommandResponse<TData>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public TData Data { get; set; }
        public CommandResponse()
        {
            this.ErrorMessage = null;
        }
        
        public static CommandResponse<TData> Success(TData data) => new CommandResponse<TData> { IsSuccess = true, Data = data };
        public static CommandResponse<TData> Failure(string error) => new CommandResponse<TData> { IsSuccess = false, ErrorMessage = error };
    }
}
