import React from 'react';
import { FilmProvider } from './Context/FilmContext/index'
import { AppUI } from './AppUI'
import './App.css';

function App() {
    return (
        <FilmProvider>
            <AppUI />
        </FilmProvider>
    );
}

export default App;