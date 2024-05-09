import argparse
import pandas as pd
import tabula


def convert_pdf_to_csv(pdf_file_path):
    tables = tabula.read_pdf(pdf_file_path, pages="all")

    counter = 0

    for i, table in enumerate(tables):
        if pdf_file_path in ["LFT.pdf", "CBC.pdf"] and counter == 2:
            break

        csv_file_path = f"table_{i + 1}.csv"
        table.to_csv(csv_file_path, index=False)

        print(f"Table {i + 1} saved to {csv_file_path}")

        counter += 1


def main():
    parser = argparse.ArgumentParser(description="Convert PDF table to CSV file.")
    parser.add_argument("pdf_file_path", type=str, help="Path to the PDF file.")

    args = parser.parse_args()
    convert_pdf_to_csv(args.pdf_file_path)


if __name__ == "__main__":
    main()
