import Slider from '@mui/material/Slider'
import {Box} from "@mui/material";
import classes from './TrackSlider.module.css'

const TrackSlider = (props: any) => {
    return (
        <div className={classes.container}>
            <Box  sx={{ width: '90%' }}>
                <Slider color={'secondary'} fullWidth {...props}></Slider>
            </Box>
        </div>
    );
};

export default TrackSlider;