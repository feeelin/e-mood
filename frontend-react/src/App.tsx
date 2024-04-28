import './App.css'
import Header from "./components/header/header.tsx";
import Player from "./components/player/Player.tsx";
import PlayerControl from "./components/playerControl/playerControl.tsx";
import {useEffect, useState} from "react";
// @ts-ignore
import useSound from "use-sound";


function App() {
    const currentTrack = 'https://mood.eureka-team.ru/api/Files/Content/Gorky_Park_-_Moscow_Calling.mp3'
    // @ts-ignore
    const [currentDuration, setCurrentDuration] = useState(0);

    const [isPlaying, setIsPlaying] = useState(false);
    // @ts-ignore
    const [play, { pause, duration, sound }] = useSound(currentTrack);


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
            <Player duration={duration} currentDuration={currentDuration}/>
        </div>
    </div>
  )
}

export default App
