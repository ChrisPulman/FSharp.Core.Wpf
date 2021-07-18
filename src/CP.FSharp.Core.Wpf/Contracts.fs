/// original source from https://github.com/fsprojects/FsXaml

namespace CP.FSharp.Core.Wpf

open System
do()

/// Used for one-way conversion from EventArgs -> other types when used with EventToCommand 
type public IEventArgsConverter = 
    abstract member Convert : EventArgs -> obj -> obj

