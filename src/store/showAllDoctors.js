import { createSlice } from "@reduxjs/toolkit";

const showAllDoctors = createSlice({
  name: "showAllDoctors",
  initialState: {
    howManyDoctors: 30,
    items: [],
    page: 1,
  },
  reducers: {
    changeHowManyDoctors(state, action) {
      state.howManyDoctors = action.payload.howManyDoctors;
    },
  },
});

export const showAllDoctorsActions = showAllDoctors.actions;

export default showAllDoctors;
