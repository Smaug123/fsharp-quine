let quote = '"'

let foo : Printf.TextWriterFormat<_> =
    """let quote = '"'

let foo : Printf.TextWriterFormat<_> =
    %c""%s%c""

printfn foo quote (foo.ToString ()) quote"""

printfn foo quote (foo.ToString ()) quote
