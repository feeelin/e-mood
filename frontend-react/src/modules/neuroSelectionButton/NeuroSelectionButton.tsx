import React from 'react';
import IconWithSubtitle from "../../ui/iconWithSubtitle/IconWithSubtitle.tsx";
import NeuroSelectionModal from "../../ui/neuroSelectionModal/NeuroSelectionModal.tsx";

interface Props{
    neuroSubtitle: string;
    active: boolean;
    setActive: (bool: boolean) => void;
}

export default function NeuroSelectionButton(props: Props) {
    const [open, setOpen] = React.useState(false);

    const handleClickOpen = () => {
        setOpen(false);
    };

    // const handleClose = () => {
    //     setOpen(false);
    // };

    return (
        <React.Fragment>
            <NeuroSelectionModal open={open}/>

            <IconWithSubtitle
                title={'Нейрорежим'}
                subtitle={props.neuroSubtitle}
                icon={'smart_toy'}
                active={props.active}
                setActive={props.setActive}
                // @ts-ignore
                onClick={(event) => handleClickOpen()}
                />
        </React.Fragment>
    );
}
