import React from 'react'
import { FilmContext } from '../../Context/FilmContext'

function FilmSearch() {
    const { searchFilm } = React.useContext(FilmContext)

    const onSubmitForm = (e) => {
        e.preventDefault()
        searchFilm(e.target[0].value)
    }

    return (
        <form onSubmit={onSubmitForm}>
            <input type="text" placeholder="Search..." />
        </form>
    )
}

export { FilmSearch }