import './App.css'
import Header from "./components/header/header.tsx";
import Player from "./components/player/Player.tsx";
import PlayerControl from "./components/playerControl/playerControl.tsx";
import {useEffect, useRef, useState} from "react";
// @ts-ignore
import useSound from "use-sound";


function App() {

    const [isPlaying, setIsPlaying] = useState(false);
    const [play, { pause, duration, sound }] = useSound('https://cdn.eureka-team.ru/music/1.mp3');

    const audioRef = useRef();
    console.log(audioRef)

    useEffect(() => {
        if(isPlaying){
            play()
        }else{
            pause()
        }
    }, [isPlaying]);

  return (
    <div className={'app'}>
        <Header/>
        <div className={'contentContainer'}>
            <PlayerControl isPlaying={isPlaying} setIsPlaying={setIsPlaying} />
            <Player/>
        </div>
    </div>
  )
}

export default App
