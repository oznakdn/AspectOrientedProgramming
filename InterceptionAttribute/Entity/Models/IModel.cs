namespace Entity.Models
{
    public interface IModel
    {
        string Message { get; set; }
        bool IsSuccess { get; set; }
    }
}
