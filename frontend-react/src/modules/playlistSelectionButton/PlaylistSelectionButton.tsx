// @ts-ignore
import React, {useState} from 'react';
import IconWithSubtitle from "../../ui/iconWithSubtitle/IconWithSubtitle.tsx";
import PlaylistSelectionModal from "../../ui/playlistSelectionModal/PlaylistSelectionModal.tsx";

interface Props{
    playlistTitle: string
    playlistDescription: string
    playlistActive: boolean
    setActive: (bool: boolean) => void;
}

const PlaylistSelectionButton = (props: Props) => {

    const [open, setOpen] = useState(false);

    const handleClickOpen = () => {
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
    };


    return (
        <div>
            <PlaylistSelectionModal
                handleClickOpen={handleClickOpen}
                handleClose={handleClose}
                open={open}
            />

            <IconWithSubtitle
                title={props.playlistTitle}
                subtitle={props.playlistDescription}
                icon={'queue_music'}
                active={props.playlistActive}
                setActive={props.setActive}
                onClick={
                // @ts-ignore
                (event) => handleClickOpen()
            }
            />
        </div>
    );
};

export default PlaylistSelectionButton;