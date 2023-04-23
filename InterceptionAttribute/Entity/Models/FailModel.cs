namespace Entity.Models
{
    public class FailModel: IModel
    {

        public FailModel(){ }
        public FailModel(string message):this()
        {
            Message = message;
            IsSuccess = false;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set ; }
    }
}
