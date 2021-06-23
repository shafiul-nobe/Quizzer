using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Models
{
    public class QueryResponse<TData>
    {
        public bool IsSuccess { get; set; }
        public TData Data { get; set; }
        public string ErrorMessage { get; set; }
        public QueryResponse()
        {
            ErrorMessage = null;
        }
        public static QueryResponse<TData> Success(TData data) => new QueryResponse<TData>{ IsSuccess = true, Data = data };
        public static QueryResponse<TData> Failure(string error) => new QueryResponse<TData>{ IsSuccess = false, ErrorMessage = error };

    }
}
