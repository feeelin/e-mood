import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.tsx'
import './index.css'
import {createTheme, ThemeProvider} from "@mui/material";
import CssBaseline from '@mui/material/CssBaseline';

import Keycloak, { KeycloakConfig, KeycloakInitOptions } from 'keycloak-js'
import {ReactKeycloakProvider} from "@react-keycloak/web";
import { AuthClientEvent, AuthClientTokens } from "@react-keycloak/core";

const keycloakProviderInitConfig: KeycloakInitOptions = {
    onLoad: 'check-sso',
    responseMode: "query",
    pkceMethod: "S256",
};

const initOptions: KeycloakConfig = {
    clientId: "tulahack-client",
    realm: 'tulahack',
    url: "https://tulahack.eureka-team.ru",
};


const keycloak = new Keycloak(initOptions);

const onKeycloakEvent = (event: AuthClientEvent) => {
    console.log('onKeycloakEvent', event);
};

const onKeycloakTokens = (tokens: AuthClientTokens) => {
    console.log('onKeycloakTokens fired, received tokens', `${tokens.token?.slice(0, 10)}...`);
};


const theme = createTheme(
    {
        palette: {
            mode: 'dark',
            secondary: {
                main: '#004f4e',
            },
            contrastThreshold: 3,
            tonalOffset: 0.2,
        },
    }
)

ReactDOM.createRoot(document.getElementById('root')!).render(
    <ReactKeycloakProvider
        authClient={keycloak}
        onTokens={(tokens) => onKeycloakTokens(tokens)}
        onEvent={onKeycloakEvent}
        initOptions={keycloakProviderInitConfig}>
        <React.StrictMode>
            <ThemeProvider theme={theme}>
                <CssBaseline />
                <App />
            </ThemeProvider>
        </React.StrictMode>
    </ReactKeycloakProvider>
)
