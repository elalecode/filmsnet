import React from 'react'
import axios from 'axios'

function useFilms (initialValue) {
    const [item, setItem] = React.useState(initialValue)
    const [loading, setLoading] = React.useState(true)
    const [error, setError] = React.useState(false)

    axios.interceptors.request.use((config) => {
        setLoading(true)
        return config
    }, (error) => {
        setError(error)
        setLoading(false)
        return Promise.reject(error)
    })

    React.useEffect(() => {
        async function fetchData() {
            let url = "/films/"
            let films = await axios.get(url)
                .then(response => response.data?.response ?? [])
                .catch((error) => setError(error))
            setItem(films)
            setLoading(false)
        }
        fetchData()
    }, [])

    const searchItem = async (search) => {
        let url = "/films/"
        if (search) {
            url = `${url}?search=${search}`
        }
        let films = await axios.get(url)
            .then(response => response.data?.response ?? [])
            .catch((error) => setError(error))
        setItem(films)
        setLoading(false)
    }

    return {
        item,
        searchItem,
        loading,
        error
    }
}

export { useFilms }