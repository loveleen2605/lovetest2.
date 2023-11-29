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
    // Add other movies based on the given data
]

let probableOscarWinners = movies |> List.filter (fun movie -> movie.IMDbRating > 7.4)

let convertRunLengthToHours (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

// Print probable Oscar winners
printfn "Probable Oscar Winners:"
probableOscarWinners |> List.iter (fun movie -> printfn "%s (%s) - IMDb Rating: %.1f" movie.Name (genreToString movie.Genre) movie.IMDbRating)

// Print run lengths in hours
printfn "\nRun Lengths in Hours:"
let runLengthInHours = movies |> List.map (fun movie -> convertRunLengthToHours movie.RunLength)
runLengthInHours |> List.iter (fun runLength -> printfn "%s" runLength)
