import classes from "./FindDoctor.module.scss";

const FindDoctor: React.FC = () => {
  return (
    <div className={classes.container}>
      <input type="text" placeholder="Search..." />
      <button>
        <span role="img" aria-label="Search">
          🔍
        </span>
      </button>
    </div>
  );
};

export default FindDoctor;
