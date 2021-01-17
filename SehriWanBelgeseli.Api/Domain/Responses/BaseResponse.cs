namespace SehriWanBelgeseli.Api.Domain.Responses {
    public class BaseResponse {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }

        public BaseResponse(string message, bool isSuccess)
        {
            this.Message = message;
            this.IsSuccess = isSuccess;
        }
    }
}
