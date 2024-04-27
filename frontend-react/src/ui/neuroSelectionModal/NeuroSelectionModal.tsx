// @ts-ignore
import React from 'react';
import DialogTitle from "@mui/material/DialogTitle";
import DialogContent from "@mui/material/DialogContent";
import DialogContentText from "@mui/material/DialogContentText";
import TextField from "@mui/material/TextField";
import DialogActions from "@mui/material/DialogActions";
import Button from "@mui/material/Button";
import Dialog from "@mui/material/Dialog";

interface Props{
    handleClickOpen: () => void;
    handleClose: () => void;
    open: boolean;
}

const NeuroSelectionModal = (props: Props) => {
    return (
            <Dialog
                open={props.open}
                // @ts-ignore
                onClose={(event) => props.handleClose}
                PaperProps={{
                    component: 'form',
                    onSubmit: (event: React.FormEvent<HTMLFormElement>) => {
                        event.preventDefault();
                        const formData = new FormData(event.currentTarget);
                        const formJson = Object.fromEntries((formData as any).entries());
                        const email = formJson.email;
                        console.log(email);
                        props.handleClose();
                    },
                }}
            >
                <DialogTitle>Нейро-режим</DialogTitle>
                <DialogContent>
                    <DialogContentText>
                        Введите текстовый запрос для генерации нейро-трека. От подробности описания зависит результат генерации.
                    </DialogContentText>
                    <TextField
                        autoFocus
                        required
                        margin="dense"
                        id="name"
                        name="prompt"
                        label="Задача для нейросети"
                        type="text"
                        fullWidth
                        variant="standard"
                    />
                </DialogContent>
                <DialogActions>
                    <Button onClick={
                        // @ts-ignore
                        (event) => props.handleClose()
                    }>Отмена</Button>
                    <Button>Начать</Button>
                </DialogActions>
            </Dialog>
    );
};

export default NeuroSelectionModal;