using System.Text.Json.Serialization;


namespace Course.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        [JsonIgnore]
        public bool IsSuccess { get; set; }

        public List<string> Errors { get; set; }


        // Static Factory Methods 

        public static ResponseDto<T> Succes(int statusCode)
        {
            return new ResponseDto<T> { Data = default(T), IsSuccess = true, StatusCode = statusCode };
        }

        public static ResponseDto<T> Succes(T data , int statusCode)
        {
            return new ResponseDto<T> { StatusCode = statusCode, Data = data , IsSuccess = true};
        }


        public static ResponseDto<T> Fail(List<string> errors , int statusCode)
        {
            return new ResponseDto<T> { Errors = errors, StatusCode = statusCode, IsSuccess = false };
        }

        public static ResponseDto<T> Fail(string error, int statusCode)
        {
            return new ResponseDto<T> {Errors = new List<string>(){error}, StatusCode = statusCode, IsSuccess = false };
        }
    }
}
