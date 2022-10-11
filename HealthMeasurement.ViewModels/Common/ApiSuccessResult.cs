using System;
using System.Collections.Generic;
using System.Text;

namespace HealthMeasurement.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObj)
        {
            IsSuccessed = true;
            Token = resultObj;
        }

        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}