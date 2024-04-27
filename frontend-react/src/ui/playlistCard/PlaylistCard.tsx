import Typography from "@mui/material/Typography";
import {Avatar} from "@mui/material";
import classes from './playlistCard.module.css'
import {IPlaylist} from "../../api/api.client.ts";

interface Props{
    name: string;
    description: string;
    coverUrl: string;
    click : (card: IPlaylist) => void;
}

const PlaylistCard = (props: Props) => {
    return (
        <div className={classes.container}>
            <Avatar alt={props.name} src={props.coverUrl} className={classes.avatar}/>
            <div className={classes.textContainer}>
                <Typography variant={'h3'} component={'h3'}>{props.name}</Typography>
                <Typography variant={'body2'} component={'p'}>{props.description}</Typography>
            </div>
        </div>
    );
};

export default PlaylistCard;