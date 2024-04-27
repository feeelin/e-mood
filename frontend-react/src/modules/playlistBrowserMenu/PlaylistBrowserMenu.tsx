// @ts-ignore
import React, {JSX, ReactNode, useState} from 'react';
import PlaylistBrowserModal from "../../ui/playlistBrowserModal/PlaylistBrowserModal.tsx";
import PlaylistBrowserIcon from "../../ui/playlistBrowserIcon/PlaylistBrowserIcon.tsx";

interface Props{
    content: any
}

const PlaylistBrowserMenu = (props: Props) => {

    const [open, setOpen] = useState(false)

    const handleClickOpen = () => {
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
    };

    return (
        <div>
            <PlaylistBrowserModal
                handleClickOpen={handleClickOpen}
                handleClose={handleClose}
                open={open}
                content={props.content}
            />

            <PlaylistBrowserIcon open={handleClickOpen}/>
        </div>
    );
};

export default PlaylistBrowserMenu;