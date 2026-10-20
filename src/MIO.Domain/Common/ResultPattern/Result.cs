using System.ComponentModel;
using System.Text.Json.Serialization;
using MIO.Domain.Common.ResultPattern.Abstractions;

namespace MIO.Domain.Common.ResultPattern;

public readonly record struct Success;

public readonly record struct Created;

public readonly record struct Updated;

public readonly record struct Deleted;

public sealed class Result
{
    public static Success Success = default;
    public static Created Created = default;
    public static Updated Updated = default;
    public static Deleted Deleted = default;
}

public sealed class Result<TValue> : IResult<TValue>
{
    private List<Error> _errors = [];
    private TValue _value = default!;
    public List<Error> Errors => IsError ? _errors! : [];
    public TValue Value => IsSuccess ? _value : default!;
    public bool IsSuccess { get;}
    public bool IsError => !IsSuccess;
    public Error TopError => (_errors.Count > 0) ? _errors[0] : default!;

    [JsonConstructor]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("For serializer only.", true)]
    public Result(TValue? value, List<Error>? errors, bool isSuccess)
    {
        if (isSuccess)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
            _errors = [];
            IsSuccess = true;
        }
        else
        {
            if (errors == null || errors.Count == 0)
            {
                throw new ArgumentException("Provide at least one error.", nameof(errors));
            }

            _errors = errors;
            _value = default!;
            IsSuccess = false;
        }
    }

    public Result(List<Error> errors)
    {
        if (errors.Count <= 0 || errors is null)
        {
            throw new ArgumentException(
                "Cannot create an ErrorOr<TValue> from an empty collection of errors. Provide at least one error.",
                nameof(errors)
            );
        }
        _errors.AddRange(errors);
        IsSuccess = false;
    }

    public Result(Error error)
    {
        if (error is null)
        {
            throw new ArgumentException(nameof(error));
        }
        _errors.Add(error);
        IsSuccess = false;
    }

    public Result(TValue value)
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }
        _value = value;
        IsSuccess = true;
    }

    public TValueNext Match<TValueNext>(
        Func<TValue, TValueNext> onValue,
        Func<List<Error>, TValueNext> onError
    ) => IsSuccess == true ? onValue(Value) : onError(Errors);

    public static implicit operator Result<TValue>(List<Error> errors) => new(errors);

    public static implicit operator Result<TValue>(Error error) => new(error);

    public static implicit operator Result<TValue>(TValue value) => new(value);
}
