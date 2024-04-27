import './App.css'
import Header from "./components/header/header.tsx";
import Player from "./components/player/Player.tsx";
import PlayerControl from "./components/playerControl/playerControl.tsx";


function App() {
  return (
    <div className={'app'}>
        <Header/>
        <div className={'contentContainer'}>
            <PlayerControl/>
            <Player/>
        </div>
    </div>
  )
}

export default App
