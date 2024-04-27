// @ts-ignore
import React from 'react';
import ModeSelection from "../../modules/modeSelection/ModeSelection.tsx";
import PlayerControlButtons from "../../modules/playerControlButtons/PlayerControlButtons.tsx";

const PlayerControl = () => {
    return (
        <div>
            <PlayerControlButtons/>
            <ModeSelection playlistTitle={'Rock Classic'}/>
        </div>
    );
};

export default PlayerControl;