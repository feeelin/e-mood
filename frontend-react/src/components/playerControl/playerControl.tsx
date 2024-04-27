// @ts-ignore
import React from 'react';
import ModeSelection from "../../modules/modeSelection/ModeSelection.tsx";
import PlayerControlButtons from "../../modules/playerControlButtons/PlayerControlButtons.tsx";

interface Props{
    isPlaying: boolean,
    setIsPlaying: (bool: boolean) => void,
}

const PlayerControl = (props: Props) => {
    return (
        <div>
            <PlayerControlButtons isPlaying={props.isPlaying} setIsPlaying={props.setIsPlaying} />
            <ModeSelection playlistTitle={'Rock Classic super beautiful'}/>
        </div>
    );
};

export default PlayerControl;