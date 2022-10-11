using System;
using System.Collections.Generic;
using System.Text;

namespace HealthMeasurement.ViewModels.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public ApiErrorResult()
        {
        }

        public ApiErrorResult(string message)
        {
            IsSuccessed = false;
            Message = message;
        }

    }
}