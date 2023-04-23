namespace Entity.Models
{
    public class SuccessModel : IModel
    {
        public SuccessModel(){}
        public SuccessModel(string message):this()
        {
            Message = message;
            IsSuccess = true;
        }
        public string Message { get; set ; }
        public bool IsSuccess { get; set ; }
    }
}
