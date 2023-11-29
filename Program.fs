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

// Part B 

let coda={
    Name="CODA" 
    runlen=111
    Genre=Drama
    Director={Name="Sian Heder"; Movies=9}
    IMBD= 8.1}
let belfast={
    Name="Belfast"
    runlen=98
    Genre=Comedy
    Director={Name="Kenneth Branagh"; Movies=23}
    IMBD= 7.3}
let dontlookup=
    {Name="Don't Look Up"
     runlen=138
     Genre=Comedy
     Director={Name="Adam McKay"; Movies=27}
     IMBD= 7.2}
let drivemycar={
    Name="Drive My Car"
    runlen=179; Genre=Drama
    Director={Name="Ryusuke Hamaguchi"; Movies=16}
    IMBD= 7.6}
let dune={
    Name="Dune"
    runlen=155
    Genre=Fantasy
    Director={Name="Denis Villeneuve"; Movies=24}
    IMBD= 8.1}
let kingrichard={
    Name="King Richard"
    runlen=144
    Genre=Sport
    Director={Name="Reinaldo Marcus Green"; Movies=15}
    IMBD= 7.5}
let LP={
    Name="Licorice Pizza"
    runlen=133
    Genre=Comedy
    Director={Name="Paul Thomas Anderson"; Movies=49}
    IMBD= 7.4}
let NA={
    Name="Nightmare Alley"
    runlen=150
    Genre=Thriller
    Director={Name="Guillermo Del Toro"; Movies=22}
    IMBD= 7.1}
     

//Part C

let movls = [coda; belfast; dontlookup; drivemycar; dune; kingrichard; LP; NA]

//Part D
let oswin = List.filter (fun movie -> movie.IMBD > 7.4) movls

printfn "Probable Oscar Winners:"
oswin |> List.iter (fun movie -> 
    printfn "%s" movie.Name
)

//Part E

