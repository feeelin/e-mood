import Slide from '@mui/material/Slide';
import { TransitionProps } from '@mui/material/transitions';
import Dialog from "@mui/material/Dialog";
// @ts-ignore
import React, {ReactNode} from 'react'
import AppBar from "@mui/material/AppBar";
import Typography from "@mui/material/Typography";
import Button from "@mui/material/Button";
import IconButton from "@mui/material/IconButton";
import Toolbar from "@mui/material/Toolbar";
import FileUpload from "../../components/FileUpload/FileUpload.tsx";

const Transition = React.forwardRef(function Transition(
    props: TransitionProps & {
        children: React.ReactElement;
    },
    ref: React.Ref<unknown>,
) {
    return <Slide direction="up" ref={ref} {...props} />;
});

interface Props {
    handleClickOpen: () => void
    handleClose: () => void
    open : boolean
    content: any
}

export default function PlaylistBrowserModal(props: Props) {

    return (
        <React.Fragment>
                <Dialog
                    fullScreen
                    open={props.open}
                    onClose={props.handleClose}
                    TransitionComponent={Transition}
                >
                    <AppBar sx={{ position: 'relative', backgroundColor: '#004f4e' }}>
                        <Toolbar>
                            <IconButton
                                edge="start"
                                color="inherit"
                                onClick={props.handleClose}
                                aria-label="close"
                            >
                            </IconButton>
                            <Typography sx={{ ml: 2, flex: 1 }} variant="h6" component="div">
                                Обзор плейлистов
                            </Typography>

                            <FileUpload/>

                            <Button autoFocus color="inherit" onClick={props.handleClose}>
                                Закрыть
                            </Button>
                        </Toolbar>
                    </AppBar>
                    {props.content}
                </Dialog>
        </React.Fragment>
    );
}