// todo : create layout component to return passed children as props
import styles from "./layout.module.css";
export default function App({ children }) {
  return <div className={styles.container}>{children}</div>;
}
