using System.Collections.Generic;

public interface ILeutenantGeneral
{
    IReadOnlyList<IPrivate> Privates { get; }
}