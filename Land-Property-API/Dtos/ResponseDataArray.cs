namespace Land_Property.API.Dtos;

public record class ResponseDataArray<T>(string Message, string? Token, T[]? Data)
{
    public ResponseDataArray(string Message) : this(Message, default, default)
    {
        this.Message = Message;
    }

    public ResponseDataArray(string Message, string Token) : this(Message, Token, default)
    {
        this.Message = Message;
        this.Token = Token;
    }

    public ResponseDataArray(string Message, T[] Data) : this(Message, default, Data)
    {
        this.Message = Message;
        this.Data = Data;
    }
}