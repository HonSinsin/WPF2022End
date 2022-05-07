namespace WPFTodo.Api.Serivce
{
    public class ApiResponse
    {
        public ApiResponse(string message, bool status = false)
        {
            this.Message = message;
            this.Status = status;
        }

        public ApiResponse(bool status, object restult)
        {
            this.Status = status;
            this.Result = restult;

        }
        private string Message { get; set; }

        private bool Status { get; set; }

        private object Result { get; set; }

    }
}
