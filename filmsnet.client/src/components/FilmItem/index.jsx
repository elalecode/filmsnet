import React from 'react'

function FilmItem({ text, actors, genres }) {
  return (
      <div>
          {text}
          <div>
              {actors.map((actor, key) => {
                  return (
                      <span key={key}>{actor.name}</span>
                  )
              })}
          </div>
          <div>
              {genres.map((genre, key) => {
                  return (
                      <span key={key}>{genre.name}</span>
                  )
              })}
          </div>
      </div>
  )
}

export { FilmItem }