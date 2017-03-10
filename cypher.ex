defmodule Cypher do
  @moduledoc """
  An Elixir version of joeolaye's substitution cipher.
  @author Uk
  """

  @lookup_table %{
    "a" => "Q",
    "b" => "W",
    "c" => "E",
    "d" => "R",
    "e" => "T",
    "f" => "Y",
    "g" => "U",
    "h" => "I",
    "i" => "O",
    "j" => "P",
    "k" => "A",
    "l" => "S",
    "m" => "D",
    "n" => "F",
    "o" => "G",
    "p" => "H",
    "q" => "J",
    "r" => "K",
    "s" => "L",
    "t" => "Z",
    "u" => "X",
    "v" => "C",
    "w" => "V",
    "x" => "B",
    "y" => "N",
    "z" => "M"
  }
  
  def do_encryption(str) do
    str
    |> String.replace(~r/[-+.^@_:,]/, "")
    |> String.replace("[", "")
    |> String.replace("]", "")
    |> String.split("", trim: true)
    |> Enum.map(fn c -> Map.get(@lookup_table, c, "*") end)
    |> Enum.join()
  end

  def do_decryption(str) do
    str
    |> String.split("", trim: true)
    |> Enum.map(fn c -> (&get_key/1).(c) end)
    |> Enum.join()
  end

  def get_key(val) do
    Map.keys(@lookup_table)
    |> Enum.filter(fn key -> Map.get(@lookup_table, key) == val end)
    |> Enum.at(0)
  end
end