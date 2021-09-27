using ClearwoxCodeChallenge.Application.Wrappers;

namespace ClearwoxCodeChallenge.Application.Constants
{
    public class ApplicationConstants
    {

        public static Response<T> SuccessMessage<T>(T obj, string message)
        {
            var response = new Response<T>
            {
                Data = obj,
                Message = message,
                Succeeded = true,
            };
            return response;
        }

        public static Response<T> FailureMessage<T>(T obj, string message)
        {
            var response = new Response<T>
            {
                Data = obj,
                Message = message,
                Succeeded = false,
            };
            return response;
        }

    }
}
