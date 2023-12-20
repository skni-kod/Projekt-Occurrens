import { configureStore } from "@reduxjs/toolkit";

import showAllDoctors from "./showAllDoctors";

const store = configureStore({
  reducer: { showAllDoctors: showAllDoctors.reducer },
});

export default store;
