namespace Land_Property.API.Dtos;

public record class ResponseData<T>(string Message, string? Token, T? Data)
{
    public ResponseData(string Message) : this(Message, default, default)
    {
        this.Message = Message;
    }

    public ResponseData(string Message, string Token) : this(Message, Token, default)
    {
        this.Message = Message;
        this.Token = Token;
    }

    public ResponseData(string Message, T Data) : this(Message, default, Data)
    {
        this.Message = Message;
        this.Data = Data;
    }
}
