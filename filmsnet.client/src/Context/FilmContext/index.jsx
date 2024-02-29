import React from 'react'
import { useFilms } from './useFilms'

const FilmContext = React.createContext()

function FilmProvider (props) {
    const {
        item: films,
        searchItem: searchFilm,
        loading,
        error
    } = useFilms([])

    const [searchValue, setSearchValue] = React.useState('')

    if (searchValue.length >= 1) {
        searchFilm(searchValue)
    }

    return (
        <FilmContext.Provider value={{
            loading,
            error,
            searchValue,
            searchFilm,
            films
        }}
        >
            {props.children}
        </FilmContext.Provider>
    )
}

export { FilmContext, FilmProvider }