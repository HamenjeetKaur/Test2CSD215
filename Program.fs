// For more information see https://aka.ms/fsharp-console-apps

// Part A

type gen =
|Horror 
|Drama
|Thriller
|Comedy
|Fantasy
|Sport

type dir={
    Name: string
    Movies: int
}

type movie={
    Name: string
    runlen: int
    Genre: gen
    Director: dir
    IMBD: float
}


