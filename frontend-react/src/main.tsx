import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.tsx'
import './index.css'
import {createTheme, ThemeProvider} from "@mui/material";
import CssBaseline from '@mui/material/CssBaseline';

const theme = createTheme(
    {
        palette: {
            mode: 'dark',   // Name of the theme
            secondary: {
                main: '#004f4e',
            },
            contrastThreshold: 3,
            tonalOffset: 0.2,
        },
    }
)

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
      <ThemeProvider theme={theme}>
          <CssBaseline />
          <App />
      </ThemeProvider>
  </React.StrictMode>,
)
