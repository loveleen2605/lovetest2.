type Genre = Horror | Drama | Thriller | Comedy | Fantasy | Sport

type Director = {
    Name: string
    Movies: int
}

type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDbRating: float
}

let genreToString (genre: Genre) =
    match genre with
    | Horror -> "Horror"
    | Drama -> "Drama"
    | Thriller -> "Thriller"
    | Comedy -> "Comedy"
    | Fantasy -> "Fantasy"
    | Sport -> "Sport"

let movies : Movie list = [
    {
        Name = "CODA"
        RunLength = 111
        Genre = Drama
        Director = { Name = "Sian Heder"; Movies = 9 }
        IMDbRating = 8.1
    }
    {
        Name = "Belfast"
        RunLength = 98
        Genre = Comedy
        Director = { Name = "Kenneth Branagh"; Movies = 23 }
        IMDbRating = 7.3
    }
    {
        Name = "Don't Look Up"
        RunLength = 138
        Genre = Comedy
        Director = { Name = "Adam McKay"; Movies = 27 }
        IMDbRating = 7.2
    }
    
]


let additionalMovies : Movie list = [
    {
        Name = "Drive My Car"
        RunLength = 155
        Genre = Drama
        Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
        IMDbRating = 7.6
    }
    {
        Name = "Dune"
        RunLength = 179
        Genre = Fantasy
        Director = { Name = "Denis Villeneuve"; Movies = 24 }
        IMDbRating = 8.1
    }
    {
        Name = "King Richard"
        RunLength = 144
        Genre = Sport
        Director = { Name = "Reinaldo Marcus Green"; Movies = 22 }
        IMDbRating = 7.5
    }
    {
        Name = "Licorice Pizza"
        RunLength = 133
        Genre = Comedy
        Director = { Name = "Paul Thomas Anderson"; Movies = 8 }
        IMDbRating = 7.4
    }
    {
        Name = "Nightmare Alley"
        RunLength = 150
        Genre = Thriller
        Director = { Name = "Guillermo Del Toro"; Movies = 15 }
        IMDbRating = 7.1
    }
]


let allMovies = movies @ additionalMovies

let probableOscarWinners = allMovies |> List.filter (fun movie -> movie.IMDbRating > 7.4)

let convertRunLengthToHours (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

printfn "Probable Oscar Winners:"
probableOscarWinners |> List.iter (fun movie -> printfn "%s (%s) - IMDb Rating: %.1f" movie.Name (genreToString movie.Genre) movie.IMDbRating)


printfn "\nRun Lengths in Hours:"
let runLengthInHours = allMovies |> List.map (fun movie -> convertRunLengthToHours movie.RunLength)
runLengthInHours |> List.iter (fun runLength -> printfn "%s" runLength)


printfn "\nAll Movie Names:"
allMovies |> List.iter (fun movie -> printfn "%s" movie.Name)
