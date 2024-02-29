import React from 'react'
import { FilmContext } from './Context/FilmContext'
import { FilmSearch } from './components/FilmSearch'
import { FilmList } from './components/FilmList'
import { FilmItem } from './components/FilmItem'

function AppUI() {
    const {
        loading,
        error,
        films,
    } = React.useContext(FilmContext)
    return (
        <div className='container'>
            <FilmSearch />
            <FilmList>
                {loading && <p>Wait me a second, loading your Film's...</p>}
                {(!loading && !films?.length) && <p>!There aren't Films!</p>}
                {error && <p>Ups! something was wrong. :/</p>}

                {films.map((film, key) => (
                    <FilmItem
                        key={key}
                        text={film.title}
                        actors={film.actors}
                        genres={film.genres}
                    />
                ))}
            </FilmList>
        </div>
    )
}

export { AppUI }