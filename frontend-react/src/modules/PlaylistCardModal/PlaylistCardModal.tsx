import {IPlaylist} from "../../api/api.client.ts";
import Typography from "@mui/material/Typography";
import Avatar from "@mui/material/Avatar";
import Modal from "@mui/material/Modal";
import classes from './playlistCardModal.module.css'
import Button from "@mui/material/Button";

interface Props {
    playlist?: IPlaylist;
    open: boolean;
}

export default function PlaylistCardModal(props: Props) {
    return (
        <Modal open={props.open}>
            <div>
                <div className={classes.contentContainer}>
                    <Avatar src={props.playlist?.coverUrl}/>
                    <div className={classes.textContainer}>
                        <Typography variant={'h3'} component={'h3'}>{props.playlist?.name}</Typography>
                        <Typography variant={'body2'} component={'p'}>{props.playlist?.description}</Typography>
                    </div>
                </div>
                <div>
                    <Button variant="contained" color="success">Добавить</Button>
                </div>
            </div>
        </Modal>
    );
}