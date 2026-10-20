namespace MIO.Domain.Common.ResultPattern.Abstractions;

interface IResult
{
    public List<Error> Errors { get; }
    public bool IsSuccess { get; }
}

interface IResult<TValue> : IResult
{
    public TValue Value { get; }
}
