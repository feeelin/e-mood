import PlaylistsCards from "../../modules/playlistsCards/PlaylistsCards.tsx";
import {useState} from "react";
import {IPlaylist} from "../../api/api.client.ts";
import PlaylistCardModal from "../../modules/PlaylistCardModal/PlaylistCardModal.tsx";
import * as React from "react";

const PlaylistsList = () => {

    const [currentCard, setCurrentCard] = useState<IPlaylist>();
    const [open, setOpen] = React.useState(false);

    const handleDrawerClose = () => {
        setOpen(false);
    };

    const handleDrawerToggle = (card: IPlaylist) => {
            setOpen(true);
            setCurrentCard(card)
    };

    return (
        <div>
            <PlaylistCardModal
                playlist={currentCard}
                open={open}
                close={handleDrawerClose}
            />
            <PlaylistsCards onCardsClick={handleDrawerToggle} />
        </div>
    );
};

export default PlaylistsList;